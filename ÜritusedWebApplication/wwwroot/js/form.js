$('.ettevote__form').hide();
const ettevote = document.getElementsByName('ettevoteform')
const osaleja = document.getElementsByName('osalejaform')
$('osalejaform').click(function (e) {
    e.preventDefault();
    osaleja.checked = true;
    ettevote.checked = false;
    $('.osavotja__form').show();
    $('.ettevote__form').hide();
});

$('ettevoteform').click(function (e) {
    e.preventDefault();
    ettevote.checked = true;
    osaleja.checked = false;
    $('.ettevote__form').show();
    $('.osavotja__form').hide();
});