
function markDone(checkbox) {    

    var row = checkbox.closest('tr');
    $(row).addClass('done');     
}