<div>
    <a id="bottom" class="anchor" accesskey="z"></a>
    <script type="text/javascript" src="public/assets/javascript/jquery.js"></script>
    <script type="text/javascript" src="public/assets/javascript/core54d3.js"></script>
    <script type="text/javascript" src="public/assets/javascript/forum_fn.js?"></script>
    <script type="text/javascript" src="public/assets/javascript/ajax.js"></script>
    <script type="text/javascript" src="public/assets/javascript/plupload.js"></script>
    <script type="text/javascript" src="public/assets/javascript/plupload_002.js"></script>
    <script type="text/javascript" src="public/assets/javascript/editor.js"></script>
    <script type="text/javascript" src="public/assets/javascript/plupload.js"></script>

    <script type="text/javascript">
        //<![CDATA[
        phpbb.plupload = {
            i18n: {
                'b': 'B',
                'kb': 'KB',
                'mb': 'MB',
                'gb': 'GB',
                'tb': 'TB',
                'Add Files': 'Add files',
                'Add files to the upload queue and click the start button.': 'Add files to the upload queue and click the start button.',
                'Close': 'Close',
                'Drag files here.': 'Drag files here.',
                'Duplicate file error.': 'Duplicate file error.',
                'File: %s': 'File: %s',
                'File: %s, size: %d, max file size: %d': 'File: %s, size: %d, max file size: %d',
                'File count error.': 'File count error.',
                'File extension error.': 'File extension error.',
                'File size error.': 'File size error.',
                'File too large:': 'File too large:',
                'Filename': 'Filename',
                'Generic error.': 'Generic error.',
                'HTTP Error.': 'HTTP error.',
                'Image format either wrong or not supported.': 'Image format either wrong or not supported.',
                'Init error.': 'Init error.',
                'IO error.': 'IO error.',
                'Invalid file extension:': 'Invalid file extension:',
                'N/A': 'N/A',
                'Runtime ran out of available memory.': 'Runtime ran out of available memory.',
                'Security error.': 'Security error.',
                'Select files': 'Select files',
                'Size': 'Size',
                'Start Upload': 'Start upload',
                'Start uploading queue': 'Start uploading queue',
                'Status': 'Status',
                'Stop Upload': 'Stop upload',
                'Stop current upload': 'Stop current upload',
                "Upload URL might be wrong or doesn't exist.": 'Upload URL might be wrong or does not exist.',
                'Uploaded %d/%d files': 'Uploaded %d/%d files',
                '%d files queued': '%d files queued',
                '%s already present in the queue.': '%s already present in the queue.'
            },
            config: {
                runtimes: 'html5',
                url: './posting.php?mode=reply&f=2&t=2',
                max_file_size: '262144b',
                chunk_size: '131072b',
                unique_names: true,
                filters: [{title: 'Images', extensions: 'gif,png,jpeg,jpg,tif,tiff,tga'}, {title: 'Archives', extensions: 'gtar,gz,tar,zip,rar,ace,torrent,tgz,bz2,7z'}],
                headers: {'X-PHPBB-USING-PLUPLOAD': '1', 'X-Requested-With': 'XMLHttpRequest'},
                file_data_name: 'fileupload',
                multipart_params: {'add_file': 'Add the file'},
                form_hook: '#postform',
                browse_button: 'add_files',
                drop_element: 'message',
            },
            lang: {
                ERROR: 'Error',
                TOO_MANY_ATTACHMENTS: 'Cannot add another attachment, 0 is the maximum.',
            },
            order: 'desc',
            maxFiles: 0,
            data: [],
        }
        //]]>
    </script>
