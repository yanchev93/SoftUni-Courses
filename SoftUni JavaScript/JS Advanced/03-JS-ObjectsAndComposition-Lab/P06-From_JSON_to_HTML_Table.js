function solve(jsonInput) {
    let data = JSON.parse(jsonInput);

    let keys = Object.keys(data[0]);

    let output = [];

    output.push('<table>');
    output.push(`\t<tr>${keys.map(k => `<th>${k}</th>`).join('')}</tr>`);

    data.forEach(element => {
        let html = '\t<tr>';
        html += Object.values(element).map(v => `<td>${v}</td>`).join('');
        html += '</tr>'

        output.push(html);
    });

    output.push('</table>');

    return output.join('\n');
}



console.log(solve('[{ "Name": "Stamat", "Score": 5.5 }, { "Name": "Rumen", "Score": 6 }]'));