async function loadRepos() {
	const input = document.getElementById('username');
	const url = `https://api.github.com/users/${input.value}/repos`;
	const ulElement = document.getElementById('repos');

	ulElement.innerHTML = '';
	const repo = await fetch(url);
	const data = await repo.json();


	data.forEach(x => {
		let liElement = document.createElement('li');
		let anchorEl = document.createElement('a');

		const htmlUrl = x.html_url;
		const fullName = x.full_name;

		anchorEl.href = htmlUrl;
		anchorEl.textContent = fullName;
		liElement.appendChild(anchorEl);
		ulElement.appendChild(liElement);
	});
}