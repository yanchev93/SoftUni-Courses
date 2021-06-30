window.addEventListener('load', solution);

function solution() {
  let fullName = document.querySelector('#fname');
  let email = document.querySelector('#email');
  let phoneNum = document.querySelector('#phone');
  let address = document.querySelector('#address');
  let postalCode = document.querySelector('#code');
  const infoPreview = document.querySelector('#infoPreview');
  const divBlock = document.querySelector('#block');

  const submitBtn = document.querySelector('#submitBTN');
  const editBtn = document.querySelector('#editBTN');
  const continueBtn = document.querySelector('#continueBTN');

  let info = [];

  submitBtn.addEventListener('click', (e) => {
    // e.preventDefault();

    if (fullName.value == '' || email.value == '') {
      return;
    }

    let liFullName = createEl('li', `Full Name: ${fullName.value}`);
    let liEmail = createEl('li', `Email: ${email.value}`);
    [liFullName, liEmail].forEach(x => infoPreview.appendChild(x));

    info.push(`fullName ${fullName.value}`);
    info.push(`email ${email.value}`);

    fullName.value = '';
    email.value = '';

    let liPhoneNum;
    if (phoneNum.value != '') {
      liPhoneNum = createEl('li', `Phone Number: ${phoneNum.value}`);
      infoPreview.appendChild(liPhoneNum);

      info.push(`phone ${phoneNum.value}`);
      phoneNum.value = '';
    }

    let liAddress;
    if (address.value != '') {
      liAddress = createEl('li', `Address: ${address.value}`);
      infoPreview.appendChild(liAddress);

      info.push(`address ${address.value}`);
      address.value = '';
    }

    let liPostalCode;
    if (postalCode.value != '') {
      liPostalCode = createEl('li', `Postal Code: ${postalCode.value}`);
      infoPreview.appendChild(liPostalCode);

      info.push(`postalCode ${postalCode.value}`);
      postalCode.value = '';
    }

    submitBtn.disabled = true;
    editBtn.disabled = false;
    continueBtn.disabled = false;

    editBtn.addEventListener('click', () => edit(infoPreview));
    continueBtn.addEventListener('click', () => sayThankYou(infoPreview));

    function edit(infoPreview) {
      infoPreview.innerHTML = '';

      info.forEach(x => {
        let info = x.split(' ');
        let infoFieldName = info[0];
        let fieldInfo = info[1];

        if (infoFieldName == 'fullName') {
          fullName.value = fieldInfo;
        } else if (infoFieldName == 'email') {
          email.value = fieldInfo;
        } else if (infoFieldName == 'phone') {
          phoneNum.value = fieldInfo;
        } else if (infoFieldName == 'address') {
          address.value = fieldInfo;
        } else if (infoFieldName == 'postalCode') {
          postalCode.value = fieldInfo;
        }
      });

      info = [];
      editBtn.disabled = true;
      continueBtn.disabled = true;
      submitBtn.disabled = false;
    }

    function sayThankYou(infoPreview) {
      divBlock.innerHTML = '';

      const h3El = createEl('h3', 'Thank you for your reservation!');
      divBlock.appendChild(h3El);
    }

  });

  function createEl(type, content, className) {
    const result = document.createElement(type);
    if (content) {
      result.textContent = content;
    }

    if (className) {
      result.className = className;
    }

    return result;
  }
}
