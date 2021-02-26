function scrollToTop() {
    $(window).scrollTop(0);
}

function ClearRadioButtonSelections() {
    
    $('input[type="radio"]').prop('checked', false);
}

function AlertFunction() {
    alert("Vastaa jokaiseen kysymykseen");
}

function addTooltips() {
    $('[data-toggle="tooltip"]').tooltip({
        trigger: 'focus'
    });
    $('body').on('click', function (e) {
        $('[data-toggle="tooltip"]').each(function () {

            // hide any open tooltips when anywhere else in the body is clicked

            if (!$(this).is(e.target) && $(this).has(e.target).length === 0 && $('.tooltip').has(e.target).length === 0) {
                $(this).tooltip('hide');
            }
        });
    });
}

function reloadPage() {
    location.reload(true);
}