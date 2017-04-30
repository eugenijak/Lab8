getDate();
function getDate() {
    var query = $.ajax("/Home/Time").done(function (result) {
        $('#date').html(result);
    });
}

setInterval(function () {
    getDate();
}, 1000);