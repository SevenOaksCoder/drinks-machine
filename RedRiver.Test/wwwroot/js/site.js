// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let buttons = document.querySelectorAll('.drink-btn');

for (let i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener('click', (e) => {
        pourDrink(e.target.id);
    })
}

const pourDrink = id => {
    const el = ".drink-" + id;
    const steps = document.querySelectorAll(el);
    let time = 0;

    document.getElementById('steps-modal').innerHTML = '';
    for (let i = 0; i < steps.length; i++) {
        document.getElementById('steps-modal')
            .innerHTML += `<p>${steps[i].value} <img class="gif" src="Clock.gif" style="width:40px; height:auto;display:inline;" /></p>`;
        const gif = document.querySelectorAll('.gif');
        
        for (let i = 0; i < gif.length; i++) {
            time += 1000;
            setTimeout(() => {
                gif[i].style.display = 'none';
            }, time);
         }
    }

    setTimeout(() => {
        const titleEl = "title-" + id;
        time += 1000;
        const title = document.getElementsByClassName(titleEl);
        document.getElementById('steps-modal').innerHTML = '';
        document.getElementById('steps-modal')
            .innerHTML += `<p>Enjoy your ${title[0].innerHTML}</p>`;
    }, time);
    
}