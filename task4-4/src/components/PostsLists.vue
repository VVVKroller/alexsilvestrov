<template>
    <section>
        <article>
            <h3>Article 1</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras cursus ante convallis lacus volutpat, ac gravida lorem fringilla. Curabitur sed elit in metus vestibulum consequat sed nec tortor. Fusce fermentum felis viverra dui sodales bibendum. Nullam a laoreet quam. Morbi vel tempor purus. Curabitur nec elit et dolor lacinia euismod. Integer congue mi lacinia nisl hendrerit cursus.

                Nam at ex vitae odio condimentum dapibus. Donec ac ligula at purus mollis fermentum eget ut turpis. Duis posuere augue diam, ut consectetur nibh sodales nec. Quisque sit amet blandit augue, et rutrum mauris. Integer consectetur venenatis diam in maximus. Cras eu nunc sit amet nisl aliquet malesuada ullamcorper eget lacus. Vivamus leo arcu, vehicula eu nibh et, ultrices posuere nunc. Sed sodales metus quis massa volutpat, et efficitur nisl mattis. Mauris vitae est hendrerit nisl fermentum pulvinar. Vivamus laoreet eros sapien, et auctor augue porttitor et. Vivamus efficitur at turpis in elementum.</p>

            <img src="../assets/pic.jpg" alt="">
            <div class="bottom">
                <div class = "tags">
                    Tags:
                    <ul>
                        <li>Tag 1</li>
                        <li>Tag 2</li>
                        <li>Tag 3</li>
                        <li>Tag 4</li>
                    </ul>
                </div>
                <div class= "rating">
                    <p>Rate this article: ★★★★☆</p>
                </div>
            </div>

        </article>
    </section>
</template>

<script>
export default {

}
</script>

<style scoped>
    section {
        display: flex;
        justify-content: center;
        align-items: center;
        width: calc(100% - 300px);
        height: 100%;
    }
    article {
        width: 800px;
        margin-left: 20px;
        padding: 10px;
        margin-top: 20px;
        text-align: left;
    }
    div.tags {
        display: flex;
        justify-content: left;
        align-items: center;
        margin-bottom: 20px;
        font-size: 14px;
        text-align: left;
    }
    ul {
        list-style: none;
        display: flex;
        justify-content: left;
    }
    div.rating {
        font-size: 14px


    }

    div.bottom {
        display: flex;
        justify-content: space-between;
        align-items: center;
    }
</style>