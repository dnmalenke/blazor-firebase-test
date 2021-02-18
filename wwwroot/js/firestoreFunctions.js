
var firestoreFunctions = {
    db : null,
    initializeFirebase: function (token) {

        firebase.initializeApp({
            apiKey: 'AIzaSyAZdDLPA1F1CuUgnk4FvQvMVOYZZNcYWm4',
            authDomain: 'blazor-firebase-test.firebaseapp.com',
            projectId: 'blazor-firebase-test'
        });

        var credential = firebase.auth.GoogleAuthProvider.credential(token);
        firebase.auth().signInWithCredential(credential);

        db = firebase.firestore();
    },
    addRobot: function (robot) {
        db.collection("robots").doc(robot.name).set(robot);
    },
    getRobots: async function () {
        return db.collection("robots").get();
    }
};