const img = document.querySelector(".img-pista")

img.addEventListener("click", () =>{
    Swal.fire({
        title: '¡Pista!',
        text: 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s',
        imageUrl: "Images/General/Al_McWhiggin.png",
        imageHeight: 400,
        confirmButtonText: 'Continuar',
        customClass: {
            image: 'custom-swal-image'
        }
    })
})
