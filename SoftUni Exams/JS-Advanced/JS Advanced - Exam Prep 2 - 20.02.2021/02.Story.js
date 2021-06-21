class Story {
    constructor(title, creator) {
        this.title = title;
        this.creator = creator;
        this._comments = [];
        this._likes = [];
    }

    get likes() {
        if (this._likes.length == 0) {
            console.log(`${this.title} has 0 likes`);
        } else if (this._likes.length == 1) {
            console.log(`${this._likes[0]} likes this story!`);
        } else {
            console.log(`${this._likes[0]} and ${this._likes.length} others like this story!`);
        }
    }

    like(username) {
        if (this._likes.includes(username)) {
            throw new Error('You can\'t like the same story twice!');
        }

        if (username == this.creator) {
            throw new Error('You can\'t like your own story!');
        }

        this._likes.push(username);
        return `${username} liked ${this.title}`;
    }

    dislike(username) {
        if (!this._likes.includes(username)) {
            throw new Error('You can\'t dislike this story!');
        }

        let personIndex = this._likes.findIndex(x => x == username);
        this._likes.splice(personIndex, 1);

        return `${username} disliked ${this.title}`;
    }

    comment(username, content, id) {
        let objComments;
        let isCreated = false;

        const idNotValid = this._comments.find(x => x.currId == id);
        if (!id || !idNotValid) {
            let currId = this._comments.length == 0 ? 1 : this._comments.length + 1;

            objComments = { username, content, currId };
            this._comments.push(objComments);

            isCreated = true;
        } else if (idNotValid) {
            console.log('stop');
        }

        if (isCreated) {
            return `${username} commented on ${this.title}`;
        }
    }
}

let art = new Story("My Story", "Anny");
art.like("John");
console.log(art.likes); // John likes this story!
art.dislike("John");
console.log(art.likes); // My Story has 0 likes
art.comment("Sammy", "Some Content");
console.log(art.comment("Ammy", "New Content")); // Ammy commented on My Story
art.comment("Zane", "Reply", 1);
// art.comment("Jessy", "Nice :)");
// console.log(art.comment("SAmmy", "Reply@", 1));
// console.log()
// console.log(art.toString('username'));
// console.log()
// art.like("Zane");
// console.log(art.toString('desc'));
