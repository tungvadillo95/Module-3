// File javascript để lấy dữ liệu

// Khai báo URL service của bạn ở đây
var baseService = "/Service";
var provinceUrl = baseService + "/GetAllProvince";
var districtUrl = baseService + "/GetAllDistrictByProvinceId";
var wardUrl = baseService + "/GetAllWardByDistrictId";
$(document).ready(function () {
    _getProvince();
    $("#ddlProvince").on('change', function () {
        var id = $(this).val();
        if (id != undefined && id != '') {
            _getDistrict(id);
        }
    });
    $("#ddlDistrict").on('change', function () {
        var id = $(this).val();
        if (id != undefined && id != '') {
            _getWard(id);
        }
    });
    $("#ddlWard").on('change', function () {
        var countryText = $("#ddlCountry option:selected").text();
        var provinceText = $("#ddlProvince option:selected").text();
        var districtText = $("#ddlDistrict option:selected").text();
        var wardText = $("#ddlWard option:selected").text();
        var html = "Quốc gia: " + countryText + " Tỉnh thành: " + provinceText + " " + "Quận huyện: " + districtText + " " + "Xã phường: " + wardText;
        html += "</br>Quê bạn thật là đẹp. Chúc mừng bạn!!!";
        $("#divResult").html(html);
    });
});
function _getProvince() {
    $.get(provinceUrl + "/" + id, function (data) {
        if (data != null && data != undefined && data.length) {
            var html = '';
            html += '<option value="">--Không chọn--</option>';
            $.each(data, function (key, item) {
                html += '<option value=' + item.Id + '>' + item.Name + '</option>';
            });
            $("#ddlProvince").html(html);
        }
    });
}
// truyền id của province vào
function _getDistrict(id) {
    $.get(districtUrl + "/" + id, function (data) {
        if (data != null && data != undefined && data.length) {
            var html = '';
            html += '<option value="">--Không chọn--</option>';
            $.each(data, function (key, item) {
                html += '<option value=' + item.Id + '>' + item.Name + '</option>';
            });
            $("#ddlDistrict").html(html);
        }
    });
}
// truyền id của district vào
function _getWard(id) {
    $.get(wardUrl + "/" + id, function (data) {
        if (data != null && data != undefined && data.length) {
            var html = '';
            html += '<option value="">--Không chọn--</option>';
            $.each(data, function (key, item) {
                html += '<option value=' + item.Id + '>' + item.Name + '</option>';
            });
            $("#ddlWard").html(html);
        }
    });
}