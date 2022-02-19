displaySwalSuccessUpload = function (message) {
    $('.modal-dialog').modal('hide');
    Swal.fire(
        message,
        'You have successfully uploaded file',
        'success'
    );    
    $('body').removeClass('modal-open');
    $('.modal-backdrop').remove();
}