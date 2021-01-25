$(document).ready(function () {
var app = new Vue({
    el: '#AppEl',
    data: {
        varName: null,
        intPrice: null,
        itemsList:[],
        GridShow: false,
        FormShow:true,
    },
    computed: {
        canSubmitOrder: function () {
            return this.lineItems.length == 0 || this.fullname == null
        },
        canAddToOrder: function () {
            return this.intPrice == null || this.varName == null
        }
    },
    created() {

        $.ajax({
            url: "../../Item/getItem",
            type: 'gET',
            ContentType : "application/json",
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                debugger;
                $(".modal-body").html("<strong>ERROR</strong><p>" + XMLHttpRequest.responseText + "</p>")
                $('#orderSuccess').modal('show')
            },
            success: function (data) {
                self.itemsList = data;
                $(".modal-body").html("<strong>Success!</strong><p>The order was successfully created</p>")
                $('#orderSuccess').modal('show')
            }
        });

    },
    methods: {
      
        //Add: function () {
        //    var data = {
        //        varName: this.varName,
        //        intPrice:this.intPrice
        //    }

        //    $.ajax({
        //        url: "/Item/Create",
        //        data: data,
        //        type: 'post',
        //        error: function (XMLHttpRequest, textStatus, errorThrown) {
        //            debugger;
        //            $(".modal-body").html("<strong>ERROR</strong><p>" + XMLHttpRequest.responseText + "</p>")
        //            $('#orderSuccess').modal('show')
        //        },
        //        success: function (data) {
        //            $(".modal-body").html("<strong>Success!</strong><p>The order was successfully created</p>")
        //            $('#orderSuccess').modal('show')
        //        }
        //    });
        //},


        Add: function () {
            var data = {
                intCustomerid: 1,
                florderTotal: 12,
                tblOrderDetails: [{
                    intItemId: 1, flQuantity: 100, flRate:89

                },{
                    intItemId: 2, flQuantity: 200, flRate:1

                }]
            }

            $.ajax({
                url: "/Item/CreateMasterDetail",
                data: data,
                type: 'post',
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    debugger;
                    $(".modal-body").html("<strong>ERROR</strong><p>" + XMLHttpRequest.responseText + "</p>")
                    $('#orderSuccess').modal('show')
                },
                success: function (data) {
                    $(".modal-body").html("<strong>Success!</strong><p>The order was successfully created</p>")
                    $('#orderSuccess').modal('show')
                }
            });
        },
        AddNew: function () {
            self.GridShow = false;
            self.FormShow = true;
        }
    }
})





    $('#datatable').dataTable();



});	
