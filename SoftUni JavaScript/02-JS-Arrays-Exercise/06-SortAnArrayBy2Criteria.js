function sortArray(input) {
    return input
        .sort((a, b) => a.length - b.length || a.localeCompare(b))
        .join('\n');
}

console.log(sortArray(['alpha',
    'beta',
    'gamma']
));

console.log('');

console.log(sortArray(['test',
    'Deny',
    'omen',
    'Default']
));