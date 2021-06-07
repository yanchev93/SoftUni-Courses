function validator(obj) {
    let output = {};

    let uri = RegExp('^[.a-zA-z ]+$');
    let method = ['GET', 'POST', 'DELETE', 'CONNECT'];
    for (const input of Object.keys(obj)) {
        if (input == 'method') {
            if (!method.includes(obj[input])) {
                throw new Error('Invalid request header: Invalid Method');
            }
        } else if (input == 'uri') {
            if (obj[input] == '*' || Regex.k obj[input]) {
                
            }
        } else if (input == 'version') {

        } else if (input == 'message') {

        }
    }
    return output;
}

validator({
    method: 'GET',
    uri: 'svn.public.catalog',
    version: 'HTTP/1.1',
    message: ''
}
);