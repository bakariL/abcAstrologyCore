$(document).ready(function () {
    setTimeout(function () {
        let loading = document.getElementById('loading').value;
        console.log(loading);
        let content = document.getElementById('isItLoaded');
        if (isItLoaded == undefined) {
            let newDiv = `
          <div class="letter">a</div>
          `;
            loading.innerHTML = newDiv;
            loading.className = 'displayIt';
        }
        else if (isItLoaded !== undefined) {
            loading.innerHTML = "";
            loading.className = 'noDisplay';
        }
    }, 600);
    setTimeout(function () {
        let loading = document.getElementById('loading').value;
        console.log(loading);
        let content = document.getElementById('isItLoaded');
        if (isItLoaded == undefined) {
            let newDiv = `
          <div class="letter">d</div>
          `;
            loading.innerHTML = newDiv;
            loading.className = 'displayIt';
        }
        else if (isItLoaded !== undefined) {
            loading.innerHTML = "";
            loading.className = 'noDisplay';
        }
    }, 900);
    setTimeout(function () {
        let loading = document.getElementById('loading').value;
        console.log(loading);
        let content = document.getElementById('isItLoaded');
        if (isItLoaded == undefined) {
            let newDiv = `
          <div class="letter">i</div>
          `;
            loading.innerHTML = newDiv;
            loading.className = 'displayIt';
        }
        else if (isItLoaded !== undefined) {
            loading.innerHTML = "";
            loading.className = 'noDisplay';
        }
    }, 1200);
});