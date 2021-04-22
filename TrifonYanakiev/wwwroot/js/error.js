$(document).ready(function () {
    
    console.log('test')
    var i = 10;
    function recursive() {
        console.log('test1')
        setTimeout(function () {
            $('#redurect_seconds').text(i);
            console.log(i)
            if (i == 1) {
                $('#seconds_span').text("second")
            }
            i--;
            if (i == 0) {
                $(location).attr("href", "/");
            }
            if (i > 0) recursive()
        }, 1000)
    }
    recursive();
})
