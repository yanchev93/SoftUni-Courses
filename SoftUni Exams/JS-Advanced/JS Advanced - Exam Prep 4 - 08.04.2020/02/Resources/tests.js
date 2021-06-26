let { Repository } = require("./solution.js");
let assert = require('chai').assert;



describe("Tests …", function () {
    let prop = {
        name: "string",
        age: "number",
        birthday: "object"
    };

    let repository = new Repository(prop);
    let entity = {
        name: "Pesho",
        age: 22,
        birthday: new Date(1998, 0, 7)
    };
    let entity2 = {
        name: "Pesho",
        age: 22,
        birthday: new Date(1998, 0, 7)
    };

    it("count", function () {

        assert.equal(repository.count, 0);
    });

    it('add', () => {
        assert.equal(repository.add(entity), 0);
        assert.equal(repository.add(entity2), 1);

        let anotherEntity = { namee: 'Teo', age: 0, birthday: new Date(1998, 0, 7) };
        assert.throws(() => repository.add(anotherEntity), `Property name is missing from the entity!`);

        let oneMoreEntity = { name: 1, age: 0, birthday: new Date(1998, 0, 7) };
        assert.throws(() => repository.add(oneMoreEntity), 'Property name is not of correct type!');
    });

    it('getId', () => {
        repository.add(entity);
        let getId = repository.getId(0);
        repository.add(entity2);
        let getId2 = repository.getId(1);

        assert.equal(repository.getId(0), getId);
        assert.equal(repository.getId(1), getId2);
        assert.throws(() => repository.update(9, entity), `Entity with id: 9 does not exist!`);

    });

    it('update', () => {
        assert.throws(() => repository.update(9, entity), `Entity with id: 9 does not exist!`);

        repository.add(entity);
        let newEntity = { name: 'T', age: 1, birthday: new Date(1998, 0, 7) };

        repository.update(0, newEntity);
        assert.equal(repository.getId(0), newEntity);
    });
});
