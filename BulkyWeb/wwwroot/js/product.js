var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url:'/admin/product/Getall' },
        "columns": [
            { data: 'ticketTitle' ,"width":"15%" },
            { data: 'description', "width": "23%" },
            { data: 'isbn', "width": "12%" },
            { data: 'publisher', "width": "10%" },
            { data: 'ticketPrice', "width": "5%" },
            { data: 'location', "width": "13%" },
            { data: 'category.name', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return ` <div class="btn-group-vertical" role="group" aria-label="Vertical button group">
                    <a href="/admin/product/upsert?id=${data}" class="btn btn-outline-primary" ><i class="bi bi-pencil-square"></i> Edit</a>
                    <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-outline-danger"><i class="bi bi-trash-fill"></i> Delete</a>
                    </div > `
                },
                "width": "12%"
            }
        ]
    });
}


function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toster.success(data.message);
                }

            })
        }
    })
}

