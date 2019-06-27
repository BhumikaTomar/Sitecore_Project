function createCommentItem(form, path) {
    var service = new ItemService({ url: '/sitecore/api/ssc/item' });
    var obj = {
        ItemName: 'comment-' + form.name.value,        
        TemplateID: '{3DF0C766-ACE7-4EA0-8AD8-9EB6941D1885}',
        Name: form.name.value,
        Comment: form.comment.value
    };

    service.create(obj)
        .path(path)
        .execute()
        .then(function (item) {
            form.name.value = form.comment.value = '';
            window.alert('Thanks. Your message will be shwon on the site shortly');
        })
        .fail(function (err) { window.alert(err); });
    event.preventDefault();
    return false;
}