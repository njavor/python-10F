//DATE AND NAMEDAY
function renderTime(){
    let dadate = new Date();

    let ev = dadate.getYear() + 1900;
    let ho = dadate.getMonth() + 1;
    let nap = dadate.getDate();
    let napok = new Array("vasárnap", "hétfő", "kedd", "szerda", "csütörtök", "péntek", "szombat");

    document.getElementById('date').innerHTML = ev + ". " + ho + ". "+ nap + ". " + napok[dadate.getDay()];
    setTimeout("renderTime()", 1000);
}
renderTime();
//