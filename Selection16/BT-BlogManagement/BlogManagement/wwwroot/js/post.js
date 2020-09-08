var posts = posts || {};

posts.delete = function (id) {
    bootbox.confirm({
        title: "Cảnh báo",
        message: "Bạn có muốn xóa post này không?",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Không'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Có'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `/Post/Delete/${id}`,
                    method: "GET",
                    contentType: 'json',
                    success: function (data) {
                        if (data.deleteResult > 0) {
                            window.location.href = "/";
                        }
                    }
                });
            }
        }
    });
}
$(document).ready(function () {
    $("#tbPosts").dataTable(
        {
            "columnDefs": [
                {
                    "targets": 2,
                    "orderable": false
                },
                {
                    "targets": 4,
                    "orderable": false,
                    "searchable": false
                }
            ]
        }
    );
});