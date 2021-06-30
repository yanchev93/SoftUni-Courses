function printDeckOfCards(cards) {
    function createCard(face, suit) {
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

    let result = [];

    for (const card of cards) {
        let face = card.substring(0, card.length - 1);
        let suit = card.substring(card.length - 1);

        try {
            result.push(createCard(face, suit));
        } catch (er) {
            console.log(`Invalid card: ${x}`);
            return;
        }

    }

    return result.join(' ');
}
