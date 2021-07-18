async function loadCommits() {
    const username = document.getElementById('username').value;
    const repo = document.getElementById('repo').value;
    const ulElement = document.getElementById('commits');
    ulElement.innerHTML = '';

    const url = `https://api.github.com/repos/${username}/${repo}/commits`;

    const response = await fetch(url);

    if (response.ok) {
        const data = await response.json();

        data.forEach(r => {
            console.log(r.commit.author.name);
            const liElement = document.createElement('li');
            liElement.textContent = `${r.commit.author.name}: ${r.commit.message}`;

            ulElement.appendChild(liElement);
        });
    } else if (response.status = '404') {
        const liElement = document.createElement('li');
        liElement.textContent = `Error: ${response.status} (Not Found)`;

        ulElement.appendChild(liElement);
    }
}