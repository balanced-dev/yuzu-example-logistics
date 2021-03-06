const gulp = require('gulp');
const paths = require('./config').paths;
const files = require('./config').files;
const server = require('./browser-sync');

const uiInventory = (done) => {

    gulp.src(files.fonts)
        .pipe(gulp.dest(paths.fonts.dest));

    gulp.src(files.images)
        .pipe(gulp.dest(paths.images.dest));
    done();
};

const run = gulp.series(uiInventory,);

exports.run = run;
exports.reload = gulp.series(run, server.reload);