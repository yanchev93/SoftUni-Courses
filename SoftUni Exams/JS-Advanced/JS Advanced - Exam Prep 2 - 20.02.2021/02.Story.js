class Story {
    constructor(title, creator) {
        this.title = title;
        this.creator = creator;
        this._comments = [];
        this._likes = [];
    }

    get likes() {
        let text = '';
        if (this._likes.length == 0) {
            text = `${this.title} has 0 likes`;
        } else if (this._likes.length == 1) {
            text = `${this._likes[0]} likes this story!`;
        } else {
            text = `${this._likes[0]} and ${this._likes.length - 1} others like this story!`;
        }

        return text;
    }

    like(username) {
        if (this._likes.includes(username)) {
            throw new Error('You can\'t like the same story twice!');
        }

        if (username == this.creator) {
            throw new Error('You can\'t like your own story!');
        }

        this._likes.push(username);
        return `${username} liked ${this.title}!`;
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

        const idNotValid = this._comments.find(x => x.idComment == id);
        if (!id || !idNotValid) {
            let idComment = this._comments.length == 0 ? 1 : this._comments.length + 1;

            objComments = { idComment, username, content, replies: [] };
            this._comments.push(objComments);

            isCreated = true;
        } else if (idNotValid) {
            let idReply = idNotValid.replies.length == 0 ? 0.1 : (idNotValid.replies.length + 1) / 10;
            idReply += idNotValid.idComment;

            const objReply = { idReply, username, content };
            idNotValid.replies.push(objReply);

            return 'You replied successfully';
        }

        if (isCreated) {
            return `${username} commented on ${this.title}`;
        }
    }

    toString(sortingType) {
        let objs = this._comments;

        if (sortingType == 'asc') {
            objs.sort((a, b) => a.idComment - b.idComment);
            for (const comment of objs) {
                if (comment.replies.length > 1) {
                    comment.replies.sort((a, b) => a.idReply - b.idReply);
                }
            }
        } else if (sortingType == 'desc') {
            objs.sort((a, b) => b.idComment - a.idComment);
            for (const comment of objs) {
                if (comment.replies.length > 1) {
                    comment.replies.sort((a, b) => b.idReply - a.idReply);
                }
            }
        } else if (sortingType == 'username') {
            objs.sort((a, b) => a.username.localeCompare(b.username));

            for (const comment of objs) {
                if (comment.replies.length > 1) {
                    comment.replies.sort((a, b) => a.username.localeCompare(b.username));
                }
            }
        }

        let output = [];

        output.push(`Title: ${this.title}`);
        output.push(`Creator: ${this.creator}`);
        output.push(`Likes: ${this._likes.length}\nComments:`);

        for (const x of objs) {
            const repliesArr = x.replies;
            output.push(`-- ${x.idComment}. ${x.username}: ${x.content}`);

            if (repliesArr == 0) {
                continue;
            }

            repliesArr.forEach(x => {
                output.push(`--- ${x.idReply}. ${x.username}: ${x.content}`);
            });
        }

        return output.join('\n');
    }
}

let art = new Story("My Story", "Anny");
art.like("John");
art.likes;
// art.dislike('Sally');
art.like('Ivan');
art.like('Steven');
art.likes;
art.comment('Anny', 'Some Content');
art.comment("Ammy", "New Content", 1);
art.comment("Zane", "Reply", 2);
art.comment("Jessy", "Nice :)");
console.log(art.comment("SAmmy", "Reply@", 2));
console.log(art.toString('asc'));