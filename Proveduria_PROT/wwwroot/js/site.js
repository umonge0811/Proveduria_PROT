function downloadFile(url) {
    const link = document.createElement('a');
    link.href = url;
    link.download = url.split('/').pop();  // Extrae el nombre del archivo
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
