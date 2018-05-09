var flag = true;
$('#header').on('click', function () {
    if (flag) {
        $('#header').addClass('black');
        flag = false;
    } else {
        $('#header').removeClass('black');
        flag = true;
    }
})