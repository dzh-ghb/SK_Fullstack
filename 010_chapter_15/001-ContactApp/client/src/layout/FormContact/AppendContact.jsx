import axios from "axios";
import { useNavigate } from "react-router-dom";
import FormContact from "./FormContact";

const AppendContact = (props) => {
    const navigate = useNavigate();

    const addContact = (contactName, contactPhoneNumber, contactEmail) => {
        const item = {
            name: contactName,
            phoneNumber: contactPhoneNumber,
            email: contactEmail
        };

        const url = `${props.baseApiUrl}/contacts`;
        // второй параметр - тело запроса
        axios.post(url, item)
            .then(
                () => navigate("/")
            );
    }

    return (
        <div className="card">
            <div className="card-header">
                <h1>Добавить контакт</h1>
            </div>
            <div className="card-body">
                <FormContact addContact={addContact} />
            </div>
        </div>
    );
}

export default AppendContact;