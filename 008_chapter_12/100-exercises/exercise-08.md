```html
<h1>Формулировка</h1>

<p>Напишите программу для вычисления скалярного произведения двух векторов в трёхмерном пространстве.</p>

<h2>Пояснение</h2>

<p>Скалярное произведение двух векторов <span class="math-tex">\(\vec{a}\)</span> и <span class="math-tex">\(\vec{b}\)</span> в трёхмерном пространстве вычисляется по формуле:</p>

<p><span class="math-tex">\(\vec{a} \cdot \vec{b} = a_x \cdot b_x + a_y \cdot b_y + a_z \cdot b_z\)</span></p>

<p>где <span class="math-tex">\(a_x, a_y, a_z\)</span>&nbsp; и <span class="math-tex">\(b_x, b_y, b_z\)</span>&mdash; соответствующие координаты векторов.</p>

<h2>Тесты</h2>

<ol>
	<li><strong>Пример 1:</strong>

	<ul>
		<li>Вход: <span class="math-tex">\(\vec{a} = (1, 2, 3), \vec{b} = (4, 5, 6)\)</span></li>
		<li>Ожидаемый вывод: <code>32</code></li>
	</ul>
	</li>
	<li><strong>Пример 2:</strong>
	<ul>
		<li>Вход: <span class="math-tex">\(\vec{a} = (-2, 3, 5), \vec{b} = (1, -3, 2)\)</span></li>
		<li>Ожидаемый вывод: <code>-1</code></li>
	</ul>
	</li>
	<li><strong>Пример 3:</strong>
	<ul>
		<li>Вход:&nbsp;<span class="math-tex">\(\vec{a} = (0, 0, 0), \vec{b} = (1, 2, 3)\)</span></li>
		<li>Ожидаемый вывод: <code>0</code></li>
	</ul>
	</li>
</ol>

<p>&nbsp;</p>

<div id="accel-snackbar" style="left:50%; top:50px; transform:translate(-50%, 0px)">&nbsp;</div>


```


### Формулировка
Напишите функцию/метод для вычисления скалярного произведения двух векторов в трёхмерном пространстве.

### Пояснение
Скалярное произведение двух векторов $\vec{a}$ и $\vec{b}$ в трёхмерном пространстве вычисляется по формуле:

$$
\vec{a} \cdot \vec{b} = a_x \cdot b_x + a_y \cdot b_y + a_z \cdot b_z
$$

где $a_x, a_y, a_z$ и $b_x, b_y, b_z$ - соответствующие координаты векторов.

### Тесты

1. **Пример 1:**
   - Вход: $\vec{a} = (1, 2, 3)$, $\vec{b} = (4, 5, 6)$
   - Ожидаемый вывод: $32$

2. **Пример 2:**
   - Вход: $\vec{a} = (-2, 3, 5)$, $\vec{b} = (1, -3, 2)$
   - Ожидаемый вывод: $-1$

3. **Пример 3:**
   - Вход: $\vec{a} = (0, 0, 0)$, $\vec{b} = (1, 2, 3)$
   - Ожидаемый вывод: $0$

