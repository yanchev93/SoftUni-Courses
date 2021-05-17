function encodeAndDecodeMessages() {
    const textAreas = document.querySelectorAll('textarea');
    const buttons = document.querySelectorAll('button');

    buttons[0].addEventListener('click', onClickEncode);
    buttons[1].addEventListener('click', onClickDecode);

    function onClickEncode(e) {
        let text = textAreas[0].value;

        let sendText = '';
        for (let i = 0; i < text.length; i++) {
            let letter = String.fromCharCode(text.charCodeAt(i) + 1);

            sendText += letter;
        }

        textAreas[0].value = '';
        textAreas[1].value = sendText;
    }

    function onClickDecode(e) {
        let text = textAreas[1].value;

        let outputText = '';
        for (let i = 0; i < text.length; i++) {
            let letter = String.fromCharCode(text.charCodeAt(i) - 1);

            outputText += letter;
        }

        textAreas[1].value = outputText;
    }

}