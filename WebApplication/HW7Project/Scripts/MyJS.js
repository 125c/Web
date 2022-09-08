var cart = [];
if (localStorage.getItem("cart")) {
    cart = JSON.parse(localStorage.getItem("cart"));
}
$('.badge-light').text(cart.length);

$('.addCart').click(function () {
    let product = $(this).closest('.card');
    let newPID = product.find('.PID').val();
    let foundItem = cart.find((item) => item.PID == newPID);
    if (foundItem === undefined) {//===是值跟型態都要一樣，不然123=="123"是true
        setCart(product);
    }
    else {
        foundItem.Amount += 1;
        localStorage.setItem("cart", JSON.stringify(cart));
        alert('商品數量已更新');
    }

    //下面程式太冗長了!!改成上面的寫法
    //let pName = product.find(".PName").text();
    //let price = product.find(".Price").attr("title");
    //let amount = 1;

    //if (cart.length > 0) {

    //    for (let index in cart) {

    //        if (newPID == cart[index]["PID"]) {
    //            cart[index]["Amount"] += 1;
    //            localStorage.setItem("cart", JSON.stringify(cart));
    //            alert('商品數量已更新');
    //            break;
    //        }
    //        else if (cart.length - 1 == index) {
    //            setCart(product);
    //        }
    //    }

    //}
    //else {
    //    setCart(product);
    //}

});

function setCart(product) {
    let newItem = {
        PID: product.find(".PID").val(),
        PName: product.find(".PName").text(),
        Price: product.find(".Price").attr("title"),
        Amount: 1
    }
    cart.push(newItem);
    localStorage.setItem("cart", JSON.stringify(cart));
    alert('已加入購物車');
    $('.badge-light').text(cart.length);
}