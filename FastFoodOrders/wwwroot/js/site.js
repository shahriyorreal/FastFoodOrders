// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


let openShopping = document.querySelector('.shopping');
let closeShopping = document.querySelector('.closeShopping');
let list = document.querySelector('.list');
let body = document.querySelector('body');
let listCard = document.querySelector('.listCard');
let total = document.querySelector('.total');
let quantity = document.querySelector('.quantity');

//openShopping.addEventListener('click', () => {
//    body.classList.add('active');
//})
//closeShopping.addEventListener('click', () => {
//    body.classList.remove('active');
//})


function changeImage1(x, image) {
	if (x == 1) {
		image.src = "images/first_active.png"
	}
	if (x == 2) {
		image.src = "images/first.png"
	}
}
function changeImage2(x, image) {
	if (x == 1) {
		image.src = "images/second_active.png"
	}
	if (x == 2) {
		image.src = "images/second.png"
	}
}
function changeImage3(x, image) {
	if (x == 1) {
		image.src = "images/salad_active.png"
	}
	if (x == 2) {
		image.src = "images/salad.png"
	}
}
function changeImage4(x, image) {
	if (x == 1) {
		image.src = "images/drink_active.png"
	}
	if (x == 2) {
		image.src = "images/drink.png"
	}
}