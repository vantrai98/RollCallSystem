
const WebpackShellPlugin = require('webpack-shell-plugin');

const path = require('path');
var glob = require("glob");
const jsFilePaths = require('./entry.js');

var filePaths = glob.sync(jsFilePaths);
var entries = {};
filePaths.map((filePath, index) => {
    var fileName = path.basename(filePath, ".jsx");
    entries[fileName] = filePath;
});

module.exports = {
    entry: entries,
    output: {
        filename: './Scripts/[name].js',
    },
    module: {
        rules: [
            {
                test: /\.jsx?$/,
                exclude: /(node_modules)/,
                loader: 'babel-loader',
                options: {
                    presets: ['@babel/preset-env']
                }
            },
            {
                test: /\.css$/,
                exclude: /(node_modules)/,
                use: 'css-loader'
            },
            {
                test: /\.ts$/,
                exclude: /(node_modules)/,
                use: 'ts-loader'
            }
        ]
    },
    plugins: [
        new WebpackShellPlugin({
            onBuildExit: 'copyDist.bat'
        })
    ]
};