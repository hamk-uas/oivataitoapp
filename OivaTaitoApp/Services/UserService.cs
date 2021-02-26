using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using OivaTaitoApp.Data;
using OivaTaitoApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OivaTaitoApp.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _db;

        public UserService(ApplicationDbContext db)
        {
            _db = db;
        }

        public AppUser GetUser(string uniqueIdentifier)
        {
            return _db.AppUsers
                .Where(u => u.GoogleId == uniqueIdentifier)
                .AsNoTracking()
                .FirstOrDefault();
        }

        public int GetUserId(string uniqueIdentifier)
        {
            return _db.AppUsers
                .AsNoTracking()
                .Where(u => u.GoogleId == uniqueIdentifier)
                .Select(u => u.Id)
                .FirstOrDefault();
        }

        public bool IsExistingUser(string uniqueIdentifier)
        {
            if (GetUserId(uniqueIdentifier) != 0)
                return true;

            return false;
        }

        public bool SaveUser(AppUser newUser)
        {
            _db.AppUsers.Add(newUser);
            _db.SaveChanges();
            return true;
        }

        public bool IsInitEvalCompleted(int userId)
        {
            AppUser appUser = _db.AppUsers
                .Where(u => u.Id == userId && u.initEvalCompleted == true)
                .AsNoTracking()
                .FirstOrDefault();

            return appUser != null;
        }

        public bool DeleteUser(AppUser user)
        {
            _db.AppUsers.Remove(user);
            _db.SaveChanges();
            return true;
        }

        /// <summary>
        /// Fetch the average score for each category from all self evaluations done by the user
        /// </summary>
        /// <param name="userId">ID for the <see cref="AppUser"/></param>
        /// <returns>
        /// <see cref="Dictionary{TKey, TValue}"/> where Key is <see cref="QuestionCategory.Id"/>
        /// and Value is the average score of all self evaluations done by the user for that category, typed as <see cref="float"/>
        /// </returns>
        public Dictionary<int, float> UserAverageScoreByCategory(int userId)
        {
            Dictionary<int, float> avgsByCat = new Dictionary<int, float>();

            List<QuestionCategory> questionCategories = GetQuestionCategories();

            foreach (QuestionCategory category in questionCategories)
            {
                /*
                 * We need to join tables between QuestionSet and SelfEvaluation
                 * to get Result.Answer column value per QuestionCategory
                 * so we can calculate the average of all self evaluation results
                 * for that particular category
                 */
                var query = from SER in _db.Set<SelfEvalResult>()
                            join Q in _db.Set<Question>() on SER.QuestionId equals Q.Id
                            join QS in _db.Set<QuestionSet>() on Q.QuestionSetId equals QS.Id
                            join SE in _db.Set<SelfEvaluation>() on SER.SelfEvaluationId equals SE.Id
                            where SE.EvaluatorId == userId && QS.QuestionCategoryId == category.Id
                            select SER.Answer;

                //Check if the query returns any results
                if (query.Count() > 0)
                {
                    //Round the average to one digit and convert it to a float
                    //Add the rounded and converted average to the dictionary with Cat ID as the key
                    avgsByCat.Add(category.Id, (float) Math.Round(query.Average(), 1));
                }
                else
                    //Query didn't return any results; add zero as the average
                    avgsByCat.Add(category.Id, 0);
            }

            return avgsByCat;
        }


        /// <summary>
        /// Fetch the average score from the latest evaluation of each category
        /// </summary>
        /// <param name="userId">Database generated ID for user</param>
        /// <returns>
        /// <see cref="Dictionary{TKey, TValue}"/> where Key is <see cref="QuestionCategory.Id"/>
        /// and Value is the average score for the category, typed as <see cref="float"/>
        /// </returns>
        public Dictionary<int, float> LatestUserAvgScorePerCat(int userId)
        {
            Dictionary<int, float> avgsByCat = new Dictionary<int, float>();

            List<QuestionCategory> questionCategories = GetQuestionCategories();

            foreach (QuestionCategory category in questionCategories)
            {
                //Get ID for tha latests self evaluation for this category
                int evalId = GetLatestSelfEvalId(userId, category.Id);

                //Fetch the average score for a particular category in a particular self evaluation
                var query = from SER in _db.Set<SelfEvalResult>()
                            join SE in _db.Set<SelfEvaluation>() on SER.SelfEvaluationId equals SE.Id
                            join Q in _db.Set<Question>() on SER.QuestionId equals Q.Id
                            join QS in _db.Set<QuestionSet>() on Q.QuestionSetId equals QS.Id
                            where SE.Id == evalId && QS.QuestionCategoryId == category.Id
                            group SER by Q.QuestionSetId into groupByCat
                            select new { 
                                QCatId = groupByCat.Key,
                                Average = (float)groupByCat.Average(x => x.Answer)
                            };

                //Check if the query returns any results
                if (query.Count() > 0)
                {
                    //The query should result in one row only, fetch it into a variable
                    var queryResult = query.FirstOrDefault();

                    //Round the average to one digit and convert it to a float
                    //Add the rounded and converted average to the dictionary with Cat ID as the key
                    avgsByCat.Add(category.Id, (float)Math.Round(queryResult.Average, 1));
                }
                else
                    //Query didn't return any results; add zero as the average
                    avgsByCat.Add(category.Id, 0);
            }

            return avgsByCat;
        }

        /// <summary>
        /// Fetch the total average score of self evaluations for each category
        /// </summary>
        /// <returns>
        /// <see cref="Dictionary{TKey, TValue}"/> where Key is <see cref="QuestionCategory.Id"/>
        /// and Value is the average score of all self evaluations for that category, typed as <see cref="float"/>
        /// </returns>
        public Dictionary<int, float> TotalAverageScoreByCategory()
        {
            Dictionary<int, float> avgsByCat = new Dictionary<int, float>();

            List<QuestionCategory> questionCategories = GetQuestionCategories();

            foreach (QuestionCategory category in questionCategories)
            {
                var query = from SER in _db.Set<SelfEvalResult>()
                            join Q in _db.Set<Question>() on SER.QuestionId equals Q.Id
                            join QS in _db.Set<QuestionSet>() on Q.QuestionSetId equals QS.Id
                            where QS.QuestionCategoryId == category.Id
                            select SER.Answer;

                //Check if the query returns any results
                if (query.Count() > 0)
                {
                    //Round the average to one digit and convert it to a float
                    //Add the rounded and converted average to the dictionary with Cat ID as the key
                    avgsByCat.Add(category.Id, (float) Math.Round(query.Average(), 1));
                }
                else
                    //Query didn't return any results; add zero as the average
                    avgsByCat.Add(category.Id, 0);
            }

            return avgsByCat;
        }



        public List<StackChartDataModel> GetUserSelfEvalAvgPerSet(int userId)
        {
            List<StackChartDataModel> data = new List<StackChartDataModel>();

            int[] evalIdArray = GetSelfEvalIdList(userId);

            foreach (int evalId in evalIdArray)
            {
                DateTime evaluatedAt = GetSelfEvalDateTime(evalId);

                var query = from SER in _db.Set<SelfEvalResult>()
                            join SE in _db.Set<SelfEvaluation>() on SER.SelfEvaluationId equals SE.Id
                            join Q in _db.Set<Question>() on SER.QuestionId equals Q.Id
                            where SE.Id == evalId && SE.EvaluatorId == userId
                            group SER by Q.QuestionSetId into serGroup
                            select new
                            {
                                QCatId = serGroup.Key,
                                Average = (float)serGroup.Average(x => x.Answer)
                            };

                StackChartDataModel dataItem = new StackChartDataModel
                {
                    AveragePerCategory = query.ToDictionary(x => x.QCatId, x => x.Average),
                    EvaluatedAt = evaluatedAt
                };

                data.Add(dataItem);
            }

            return data;
        }

        /// <summary>
        /// Fetch all <see cref="QuestionCategory"/>s. Includes all <see cref="QuestionSet"/>s and <see cref="Question"/>s.
        /// </summary>
        public List<QuestionCategory> GetQuestionCategories()
        {
            return _db.QuestionCategories
                .Include(qc => qc.QuestionSets)
                    .ThenInclude(qs => qs.Questions)
                .AsNoTracking()
                .ToList();
        }

        /// <summary>
        /// Return number of <see cref="Question"/>s we have
        /// </summary>
        public int GetQuestionCount()
        {
            return _db.Questions.Count();
        }

        /// <summary>
        /// Return number of <see cref="Question"/>s for the given <see cref="QuestionCategory"/> ID
        /// </summary>
        /// <param name="categoryId">ID of <see cref="QuestionCategory"/></param>
        public int GetCategoryQuestionCount(int categoryId)
        {
            return _db.Questions
                .AsNoTracking()
                .Where(q => q.QuestionSet.QuestionCategoryId == categoryId)
                .Count();
        }

        public Task<List<AppUser>> GetUsers()
        {
            return _db.AppUsers
                .AsNoTracking()
                .ToListAsync();
        }

        public Task<List<SelfEvaluation>> GetSelfEvalsAsync(int userId)
        {
            return _db.SelfEvaluations
                .AsNoTracking()
                .Where(ser => ser.EvaluatorId == userId)
                .ToListAsync();
        }

        public Task<int> GetSelfEvalCountAsync(int userId)
        {
            return _db.SelfEvaluations
                .AsNoTracking()
                .Where(se => se.EvaluatorId == userId)
                .CountAsync();
        }

        /// <summary>
        /// Fetch IDs of all <see cref="SelfEvaluation"/>s completed by the user
        /// </summary>
        /// <param name="userId">ID for the <see cref="AppUser"/></param>
        private int[] GetSelfEvalIdList(int userId)
        {
            return _db.SelfEvaluations
                .AsNoTracking()
                .Where(se => se.EvaluatorId == userId)
                .Select(se => se.Id)
                .ToArray();
        }

        /// <summary>
        /// Fetch ID of the latest <see cref="SelfEvaluation"/> for a particular <see cref="QuestionCategory"/> completed by the user
        /// </summary>
        /// <param name="userId">ID for the <see cref="AppUser"/></param>
        /// <param name="qCatId">ID for the <see cref="QuestionCategory"/></param>
        /// <returns>ID of the latest <see cref="SelfEvaluation"/></returns>
        private int GetLatestSelfEvalId(int userId, int qCatId)
        {
            var query = from SE in _db.Set<SelfEvaluation>()
                         join SER in _db.Set<SelfEvalResult>() on SE.Id equals SER.SelfEvaluationId
                         join Q in _db.Set<Question>() on SER.QuestionId equals Q.Id
                         join QS in _db.Set<QuestionSet>() on Q.QuestionSetId equals QS.Id
                         where SE.EvaluatorId == userId && QS.QuestionCategoryId == qCatId
                         orderby SE.Id descending
                         select SE.Id;

            if (query.Count() > 0)
                return query.FirstOrDefault();
            else
                return 0;
        }

        /// <summary>
        /// Fetch the <see cref="DateTime"/> column value for a <see cref="SelfEvaluation"/>
        /// </summary>
        /// <param name="selfEvaluationId">Id of <see cref="SelfEvaluation"/></param>
        private DateTime GetSelfEvalDateTime(int selfEvaluationId)
        {
            return _db.SelfEvaluations
                .AsNoTracking()
                .Where(se => se.Id == selfEvaluationId)
                .Select(se => se.EvaluatedAt)
                .SingleOrDefault();
        }
    }
}
