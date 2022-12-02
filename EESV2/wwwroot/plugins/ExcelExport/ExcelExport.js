
document, addEventListener("DOMContentLoaded", () => {
    //let datatables = document.getElementsByClassName("excel-export");
    let datatables = document.getElementsByClassName("data-table");
    for (datatable of datatables) {
        let btn = document.createElement('button');
        btn.innerText = "خروجی اکسل";
        btn.classList.add('btn');
        btn.addEventListener('click', () => {
            fnExcelReport(datatable)
        });
        datatable.appendChild(btn);
    }
})


function fnExcelReport(datatable) {
    var tab_text = "<table>";
    var tab = $('#' + datatable.id).DataTable();
    tab_text += "<tr>";
    let row0children = datatable.rows[0].children;
    for (var j = 0; j < row0children.length; j++) {
        tab_text += "<th>" + row0children[j].innerText + "</th>";
    }
    tab_text += "</tr>";
    var rows = tab.rows().data();
    for (var i = 0; i < rows.length; i++) {
        tab_text += "<tr>";
        for (var j = 0; j < rows[i].length; j++) {
            tab_text += "<td>" + rows[i][j] + "</td>";
        }
        tab_text += "</tr>";
    }
    debugger
    tab_text = tab_text + "</table>";
    tab_text = tab_text.replace(/<a(.*?)<\/a>/g, "");
    tab_text = tab_text.replace(/<img[^>]*>/gi, ""); 
    tab_text = tab_text.replace(/<input[^>]*>|<\/input>/gi, ""); 
    var ua = window.navigator.userAgent;
    var msie = ua.indexOf("MSIE ");
    debugger
    if (msie > 0 || !!navigator.userAgent.match(/Trident.*rv\:11\./))      // If Internet Explorer
    {
        txtArea1.document.open("txt/html", "replace");
        txtArea1.document.write(tab_text);
        txtArea1.document.close();
        txtArea1.focus();
        sa = txtArea1.document.execCommand("SaveAs", true, "Say Thanks to Sumit.xls");
    }
    else                 //other browser not tested on IE 11
    {
        debugger
        sa = window.open('data:application/vnd.ms-excel,' + encodeURIComponent(tab_text));
    }



    return (sa);
}
