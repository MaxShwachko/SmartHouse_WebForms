$(document).ready(function () {

    var targetValue;

    var sel = document.getElementById("DeviceList");
    sel.onchange = function () {
        if (sel.value == "Lamp") {
            document.getElementById("LampTypeList").hidden = false;
        }
        else
        {
            document.getElementById("LampTypeList").hidden = true;
        }
    };
})