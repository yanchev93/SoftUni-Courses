function solve() {
   const products = document.querySelectorAll('.product');
   const textArea = document.querySelector('textarea');
   const checkout = document.querySelector('.checkout');
   const allButtons = document.querySelectorAll('button');

   let addButtons = [];
   Array.from(products).forEach(b => addButtons.push(b.children[2]));
   addButtons.forEach(b => b.addEventListener('click', onClickAdd));
   
   let productsBag = new Set();
   let totalPrice = 0;
   
   function onClickAdd(ev) {
      let product = ev.target.parentNode.parentNode;
      let name = product.querySelector('.product-title').textContent;
      let money = Number(product.querySelector('.product-line-price').textContent);
      
      productsBag.add(name);
      totalPrice += money;
      
      textArea.value += `Added ${name} for ${money.toFixed(2)} to the cart.\n`;
   }
   
   checkout.addEventListener('click', onClickCheckout);
   function onClickCheckout() {
      textArea.value += `You bought ${[...productsBag].join(', ')} for ${totalPrice.toFixed(2)}.`;

      allButtons.forEach(b => b.disabled = true);
   }
}