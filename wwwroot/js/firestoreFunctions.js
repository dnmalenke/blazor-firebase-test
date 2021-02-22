
// https://www.freecodecamp.org/news/the-firestore-tutorial-for-2020-learn-by-example/
var firestoreFunctions = {
    db: null,
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
    addRobot: async function (robot) {
        await db.collection("robots").doc(robot.robotNumber.toString()).set(robot);
    },
    deleteRobot: async function (robot) {
       await db.collection("robots").doc(robot.robotNumber.toString()).delete(robot);
    },
    getRobots: async function () {
        return db.collection("robots").get().then((snapshot) => {
            const data = snapshot.docs.map((doc) => ({
                ...doc.data()
            }));
            return data;
        });
    }
};