using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;
using OivaTaitoApp.Data;
using OivaTaitoApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace OivaTaitoApp.Services
{
    public class EvaluationService
    {
        private readonly ApplicationDbContext _db;

        public EvaluationService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<QuestionCategory> GetQuestionCategories()
        {
            return _db.QuestionCategories
                .Include(qc => qc.QuestionSets)
                    .ThenInclude(qs => qs.Questions)
                .AsNoTracking()
                .ToList();
        }

        public List<QuestionSet> GetQuestionSets(int questionCategoryId)
        {
            return _db.QuestionSets
                .Where(qs => qs.QuestionCategoryId == questionCategoryId)
                .Include(qs => qs.Questions)
                .AsNoTracking()
                .ToList();
        }

        public List<ImprovementLink> GetImprovementLinks(int imrovementId)
        {
            return _db.ImprovementLinks
                .Where(il => il.EvalImprovementId == imrovementId)
                .AsNoTracking()
                .ToList();
        }

        public int GetUserId(string uniqueIdentifier)
        {
            return _db.AppUsers
                .AsNoTracking()
                .Where(u => u.GoogleId == uniqueIdentifier)
                .Select(u => u.Id)
                .FirstOrDefault();
        }

        public bool SaveUser(AppUser newUser)
        {
            _db.AppUsers.Add(newUser);
            _db.SaveChanges();
            return true;
        }

        public EvalFeedback GetFeedback(int questionSetId, float pointsAverage)
        {
            return _db.EvalFeedbacks
                .Where(ef => ef.QuestionSetId == questionSetId && ef.MinPts <= pointsAverage && ef.MaxPts >= pointsAverage)
                .AsNoTracking()
                .FirstOrDefault();
        }

        public EvalImprovement GetImprovement(int questionSetId)
        {
            return _db.EvalImprovements
                .Where(ei => ei.QuestionSetId == questionSetId)
                .AsNoTracking()
                .FirstOrDefault();
        }

        public bool CreateSelfEvaluation(List<SelfEvalResult> resultList, int userId)
        {
            // Make sure the foreign key column is going to match
            // with the new SelfEvaluation object we create
            // This is to make sure EF understands the data is related
            resultList.ForEach(ser => ser.SelfEvaluationId = 0);

            //Create new SelfEval object
            SelfEvaluation selfEvaluation = new SelfEvaluation()
            {
                Id = 0,
                EvaluatorId = userId,
                EvaluatedAt = DateTime.Now,
                SelfEvalResults = resultList
            };

            _db.SelfEvaluations.Add(selfEvaluation);
            _db.SaveChanges();

            return true;
        }

        public bool SetInitEvalCompleted(int userId)
        {
            AppUser user = _db.AppUsers
                .SingleOrDefault(au => au.Id == userId && au.initEvalCompleted == false);

            if (user == null)
                return false;

            user.initEvalCompleted = true;
            _db.SaveChanges();

            return true;
        }
    }
}
