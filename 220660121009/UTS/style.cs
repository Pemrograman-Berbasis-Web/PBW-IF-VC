/* Resetting default margin and padding */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

/* Basic page styling */
body {
    font-family: 'Arial', sans-serif;
    background-image: url('../wallpaperflare.com_wallpaper.jpg'); /* Ganti path jika perlu */
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 100vh;
}

/* Centered container */
.container {
    width: 80%;
    max-width: 1200px;
    background-color: rgba(255, 255, 255, 0.9); /* Transparansi latar belakang */
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0px 4px 8px rgba(0, 0, 0, 0.2);
}

/* Styling for headings and paragraphs */
h1, h2, h3, h4, h5, h6 {
    color: #333;
    margin-bottom: 10px;
}

p {
    color: #666;
    line-height: 1.6;
    margin-bottom: 15px;
}

/* Button styling */
.button {
    display: inline-block;
    padding: 10px 20px;
    font-size: 16px;
    color: white;
    background-color: #007bff;
    border: none;
    border-radius: 5px;
    text-decoration: none;
    cursor: pointer;
    transition: background-color 0.3s ease;
}

.button:hover {
    background-color: #0056b3;
}
