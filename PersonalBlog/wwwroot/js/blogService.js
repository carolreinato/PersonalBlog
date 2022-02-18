define(['./template.js'], function (template) {
    const blogPostsUrl = '/Home/LatestBlogPost/';

    function loadLatestBlogPosts() {
        fetch(blogPostsUrl)
            .then(function (response) {
                return response.json();
            })
            .then(function (data) {
                template.appendBlogList(data);
            })
            .catch(function (error) {
                console.log('Erro ao carregar blogs:', error);
            });
    }

    return {
        loadLatestBlogPosts: loadLatestBlogPosts
    }
});