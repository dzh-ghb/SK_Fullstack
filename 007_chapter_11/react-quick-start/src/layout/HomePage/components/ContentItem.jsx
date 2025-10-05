import React from 'react';

const subHeader = "NDBT";

const ContentItem = () => {
    return (
        <div>
            {/* фигурные скобки нужны, так как это JS-вкрапление */}
            {Array.from({ length: 3 }, (_, index) =>
                <div className="card m-3" key={index}>
                    <img src={`https://cataas.com/cat?width=${index + 1337}`} className="card-img-top" alt="..." />
                    <div className="card-body">
                        <h5 className="card-title">{subHeader} {'#' + index}</h5>
                        <p className="card-text">Some quick example text to build on the card title and make up the bulk of the card’s content.</p>
                    </div>
                </div>
            )}
        </div>
    )
}

export default ContentItem;