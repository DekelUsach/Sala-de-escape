﻿const darkmode = document.querySelector(".cambiar-modo")
const body = document.body

darkmode.addEventListener("click", () => {
    body.classList.toggle("dark-mode")
    if(darkmode.innerText == "Cambiar a dark mode"){
        darkmode.innerHTML = "Cambiar a light mode"
    }
    else{
        darkmode.innerHTML = "Cambiar a dark mode"
    }
    
})