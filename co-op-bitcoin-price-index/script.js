document.addEventListener('DOMContentLoaded', main)
setInterval(asdf, 1000);

function asdf()
{
    main();
    updateTime();
}

async function main(){

    let USDdiv = document.querySelector('#USD');
    let GBPdiv = document.querySelector('#GBP');
    let EURdiv = document.querySelector('#EUR');
    let TIMEdiv = document.querySelector('#time');

    let szotar = await olvaso_fetch("https://api.coindesk.com/v1/bpi/currentprice.json");
    
    TIMEdiv.innerHTML = szotar.time.updateduk;
    USDdiv.innerHTML=szotar.bpi.USD.rate;
    GBPdiv.innerHTML=szotar.bpi.GBP.rate;
    EURdiv.innerHTML=szotar.bpi.EUR.rate;
}

async function olvaso_fetch(url){
    let promise = await fetch(url);
    let promise_json = await promise.json();
    return promise_json;
}

function updateTime(){
    let kimeno = document.querySelector("#ido");

    let currentTime = new Date();
    let hours = currentTime.getHours();
    let minutes = currentTime.getMinutes();
    let seconds = currentTime.getSeconds();
    if (minutes < 10){
        minutes = "0" + minutes;
    }
    if (seconds < 10){
        seconds = "0" + seconds;
    }
    let t_str = hours + ":" + minutes + ":" + seconds + " ";
    kimeno.innerHTML = t_str;
}