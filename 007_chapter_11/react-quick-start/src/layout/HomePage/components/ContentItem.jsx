import React from 'react';

const ContentItem = (props) => {
    return (
        <div>
            {/* фигурные скобки нужны, так как это JS-вкрапление */}
            {props.setOfLabels.map((item, index) =>
                <div className="card m-3" key={index}>
                    <img src={`${props.imgSrc}${index + 1337}`} className="card-img-top" alt={props.imgAlt} />
                    <div className="card-body">
                        <h5 className="card-title">{item.cardTitle}</h5>
                        <p className="card-text">{item.cardText}</p>
                    </div>
                </div>
            )}
        </div>
    )
}

export default ContentItem;