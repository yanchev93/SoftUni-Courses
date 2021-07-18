let section = undefined;

function initialize(domElement){
    section = domElement;
}

async function getView(){
    return section;
}

let navBar = {
    initialize,
    getView
}

export default navBar;