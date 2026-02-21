import React from "react";
import { Link } from "react-router-dom";

const RowTableContact = (props) => {
    return (
        // <tr onDoubleClick={() => { props.deleteContact(props.id) }}>
        <tr>
            <td>{props.id}</td>
            <td>{props.name}</td>
            <td>{props.phoneNumber}</td>
            <td>{props.email}</td>
            <td>
                <Link
                    to={`/contact/${props.id}`}
                    className="btn btn-primary btn-sm">
                    Подробнее
                </Link>
            </td>
        </tr>
    );
}

export default RowTableContact;