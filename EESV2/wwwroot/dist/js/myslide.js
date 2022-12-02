const slides = document.querySelector('.slideritem').children;
const next = document.querySelector('.next');
const prev = document.querySelector('.prev');
const totalslides = slides.length;


next.onclick = function () {
     myfunc('next'); }
prev.onclick = function () {
     myfunc('prev'); }


let index = 0;
function myfunc(direction) {
    progress()
    if (direction == 'next') {
        if (index == totalslides - 1) {
            index = 0;
        } else {
            index++ 
        }
    }

    if (direction== 'prev') {
        if (index == 0) {
            index=totalslides-1;
        } else {
            index-- 
        }
    }
    clearInterval(timer);
    timer=setInterval(myautoslid,zaman)

    for(let i=0 ; i<slides.length ; i++){
        slides[i].classList.remove('active');
    }
    slides[index].classList.add('active');
}




let zaman = 3000;
function progress() {
    document.querySelector('.progress').innerHTML=""
    const div = document.createElement('div');
    div.style.width='300px';
    div.style.height='10px';
    div.style.position="absolute";
    div.style.left="0";
    div.style.top="0";
    div.style.backgroundColor="#a37bc9";
    div.style.animation="progress " + zaman/1000 + "s linear";
    // /////////باید بعد از پروگرس خط بالا یک فاصله باشد تا زمان به آن نچسبد اما ثانیه نیاز به چسبیدن دارد و نیاز به فاصله در زمان نیست
    document.querySelector(".progress").appendChild(div);
}
progress()

function myautoslid(){
    myfunc('next');
}
let timer= setInterval(myautoslid,zaman)