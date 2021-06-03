function cards(face, suit) {
    const suitToString = {
        S: '\u2660',
        H: '\u2665',
        D: '\u2666',
        C: '\u2663'
    };

    const faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];

    if (!faces.includes(face)) {
        throw new Error('Error');
    }

    if (!(Object.keys(suitToString).includes(suit))) {
        throw new Error('Error');
    }

    return {
        faces,
        suit,
        toString() {
            return `${face}${suitToString[suit]}`;
        }
    };
}

const myCard = cards('A', 'S');
console.log(myCard.toString());
const myCardTwo = cards('10', 'H');
console.log(myCardTwo.toString());
const myCardThree = cards('11', 'C');
console.log(myCardThree.toString());