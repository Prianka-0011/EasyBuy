var removeCartItemButton = document.getElementsByClassName("btn-danger");
console.log(removeCartItemButton);
for (var i = 0; i < removeCartItemButton.length; i++) {
    var button = removeCartItemButton[i];
    button.addEventListener('click', function{
        var buttonClicked = event.target;
    });
}