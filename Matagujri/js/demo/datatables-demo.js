// Call the dataTables jQuery plugin
//$(document).ready(function () {
//    var dat = {};
//    $('#dataTable').DataTable(
//        {
//            data:dat
//        });
//});


$(document).ready(function () {
    $("#dataTable").DataTable({

        "dataTable": true, // for show progress bar  
        "serverSide": true, // for process server side  
        "filter": true, // this is for disable filter (search box)  
        "orderMulti": false, // for disable multiple column at once  
        "pageLength": 5,
      

        "ajax": {
            "url": "http://localhost:50889/api/MataGujri/GetStudentList",
            "type": "POST",
            "datatype": "json"
        },

        "columnDefs":
            [{
                "targets": [0],
                "visible": false,
                "searchable": false
            }
            //    ,
            //{
            //    "targets": [6],
            //    "searchable": false,
            //    "orderable": false
            //},
            //{
            //    "targets": [7],
            //    "searchable": false,
            //    "orderable": false
            //    }
            ],

        "columns": [
            { "data": "StudentId", "name": "StudentId", "autoWidth": true },
            { "data": "Name", "name": "Name", "autoWidth": true },
            { "data": "Email", "title": "Email", "name": "ContactName", "autoWidth": true },
            { "data": "Mobile", "name": "Mobile", "autoWidth": true },
            { "data": "Address", "name": "Address", "autoWidth": true },
            { "data": "Pincode", "name": "Pincode", "autoWidth": true },
            //{
            //    "render": function (data, type, full, meta) { return '<a class="btn btn-info" href="/Demo/Edit/' + full.CustomerID + '">Edit</a>'; }
            //},
            //{
            //    data: null, render: function (data, type, row) {
            //        return "<a href='#' class='btn btn-danger' onclick=DeleteData('" + row.CustomerID + "'); >Delete</a>";
            //    }
            //},

        ]

    });
});  
