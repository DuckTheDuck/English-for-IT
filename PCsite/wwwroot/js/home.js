function loadPartial(partialName) {
    $.get('/Hardware/' + partialName, function (data) {
        $('#partialContainer').html(data);
    });
}