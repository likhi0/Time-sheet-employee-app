import logo from './logo.svg';
import './App.css';
import AddProfiles from './components/AddProfiles';
import RegisterUser from './components/RegisterUser';
import TimeSheet from './components/TimeSheet';
import LoginUser from './components/LoginUser';
//import App1 from'./components/App1';
function App() {
  return (
    // <div className="App">
    //   <div className="Components">
    //     <div className="row">
    //       <div classsName="AddProfiles">
    //         <AddProfiles/>
    //       </div>
    //     </div>
    //   </div>
      
    // </div>
    // <div className="app-container">
    //   <h1 className="center">TimeSheetHREmployee</h1>
    //   <LoginUser/>
    // </div>
    <div>
      <TimeSheet/>
    </div>
  );
}

export default App;
