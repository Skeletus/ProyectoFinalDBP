const toggle = document.getElementById('toggleDark');
const body = document.querySelector('body');

toggle.addEventListener('click', function(){
    this.classList.toggle('bi-moon');
    if(this.classList.toggle('bi-brightness-high-fill')){
        body.style.background = 'white';
        p.style = '"#3d3d5c';
        body.style.color = "#3d3d5c";
        body.style.transition = '2s';
        const para = document.querySelector("div");
        para.classList.style.color = "#3d3d5c";
        /*
        var elements = document.getElementsByClassName('content'); // get all elements
        for(var i = 0; i < elements.length; i++)
        {
            elements[i].style.backgroundColor = "#3d3d5c";
        }
        */
    }else{
        body.style.background = "#3d3d5c";
        p.style = '"#3d3d5c';
        body.style.color = 'white';
        body.style.transition = '2s';
    }
});