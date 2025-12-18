import React from "react";

const RowTableContact = (props) => {
    return (
        <tr onDoubleClick={() => { props.deleteContact(props.id) }}>
            <td>{props.id}</td>
            <td>{props.name}</td>
            <td>{props.phoneNumber}</td>
            <td>{props.email}</td>
        </tr>
    );
}

export default RowTableContact;