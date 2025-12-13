import React from "react";

const RowTableContact = (props) => {
    return (
        <tr>
            <td>{props.id}</td>
            <td>{props.name}</td>
            <td>{props.phoneNumber}</td>
            <td>{props.email}</td>
        </tr>
    );
}

export default RowTableContact;