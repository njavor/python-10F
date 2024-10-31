let themeL = true;

document.addEventListener('DOMContentLoaded', main());

//CHANGE THEME
function changeTheme(){
    if(themeL){
        localStorage.setItem('theme', 'dark');
        document.documentElement.setAttribute('data-theme', 'dark');
        document.getElementById('ms-text').textContent = "világos";
    } else{
        localStorage.setItem('theme', 'light');
        document.documentElement.setAttribute('data-theme', 'light');
        document.getElementById('ms-text').textContent = "sötét";
    }
    themeL = !themeL;
}
//

function main(){
    if(localStorage.getItem('theme') == 'dark'){ changeTheme(); }
    else{ document.getElementById('ms-text').textContent = "sötét"; }
}