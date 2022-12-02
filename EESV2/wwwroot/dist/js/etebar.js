function myfunction(){
    var inp1, inp2, result;
    var inp1 = document.getElementByName("UserName").value;
    var inp2 = document.getElementByName("PassWord").value;
    
    if ( isNaN(inp1) || inp1.length!=6 ) {
        alert("کد پرسنلی یا رمز عبور اشتباه وارد شده است.");
        return false;
    }
    else {
        return true;
    }
}