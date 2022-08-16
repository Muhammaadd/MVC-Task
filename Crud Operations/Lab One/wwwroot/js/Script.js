var otherlinks = document.getElementById("otherlinks");
var megalinks = document.querySelector(".megalinks");
otherlinks.onclick = function(){
    megalinks.classList.toggle("display");
    setTimeout(function(){
    megalinks.classList.toggle("margin");
    },10)
}